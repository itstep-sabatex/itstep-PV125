// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Text;


int CountUserWithFilter(IDbConnection connection,int filter)
{
    //var command = connection.CreateCommand();
    //command.CommandText = $"select count(Id) from [User] where smallintField = {filter}";
    //var count = command.ExecuteScalar();
    //return (int)count;

    // 12-05-2022 12/05/2022 05/12/2022 12.05.2022
 
    var command = connection.CreateCommand();
    command.CommandText = "select count(Id) from [User] where smallintField = @filter";
    var smallintField = command.CreateParameter();
    smallintField.ParameterName = "filter";
    smallintField.Value = filter;
    var count = command.ExecuteScalar();
    return (int)count;

}

void CreteTableStudent(IDbConnection connection)
{
    var command = connection.CreateCommand();
    command.CommandText = "CREATE TABLE[dbo].[Student]"+
                          "("+
                            "[Id] INT NOT NULL IDENTITY," +
                            "[Name] NCHAR(50) NOT NULL," +
                            "[Birthday] DATE NOT NULL," +
                            "PRIMARY KEY CLUSTERED([Id] ASC)" +
                          ");";
    command.ExecuteNonQuery();
}

Console.WriteLine("Hello, World!");
void AddRandomUsers(IDbConnection connection,IDbTransaction tr, int count)
{
    var names = new string[] {"Ivan","Semen","Petro","Stas","Jonn","Marry","Julie","Iren","Peter","Jane"};
    var rnd = new Random();
    var command = connection.CreateCommand();
    command.Transaction = tr;
    command.CommandText = "insert into [Student] ([Name],[Birthday]) values (@name,@birthday)";
    var startDate = new DateTime(1970,1,1);   
    var endDate = new DateTime(2010, 12, 31);
    int range = (endDate - startDate).Days;
    var name = command.CreateParameter();
    name.ParameterName = "name";
    var birthday = command.CreateParameter();
    birthday.ParameterName = "birthday";
    command.Parameters.Add(name);
    command.Parameters.Add(birthday);

    for (int i = 0; i < count; i++)
    {
        name.Value = names[rnd.Next(names.Length)];
        birthday.Value = startDate.AddDays(rnd.Next(range));// count > 50% (<1990)
        command.ExecuteNonQuery();
    }

}


using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\serhi\Source\Repos\sabatex\PV125\WinForms\WinFormsHelloWorld\test.mdf;Integrated Security=True"))
{

    connection.Open();
    IDbCommand command = connection.CreateCommand();
    command.CommandText = "select count(Id) from [User]";
    var count = command.ExecuteScalar();
    Console.WriteLine(count);

    //command = connection.CreateCommand();
    //command.CommandText = "insert into [User] (Id) values (5)";
    //command.ExecuteNonQuery();
    var tr = connection.BeginTransaction();
    try
    {
        AddRandomUsers(connection, tr, 50);
        tr.Commit();
    }
    catch (Exception ex)
    {
        tr.Rollback();
    }

    

    command = connection.CreateCommand();
    command.CommandText = "select * from [Student]";
    var reader = command.ExecuteReader();
    bool first = true;
    int number = 0;
    while (reader.Read())
    {
        number++;
        // N  Id   binintField
        // 1. 1    23
        // 2. 2    45
        if (first)
        {
            first = false;
            StringBuilder header = new StringBuilder("N ");
            for (int i = 0; i < reader.FieldCount; i++)
            {
                header.Append("\t"+reader.GetName(i));
            }
            Console.WriteLine(header.ToString());

        }
        StringBuilder dataLine = new StringBuilder($"{number} ");
        for (int i = 0; i < reader.FieldCount; i++)
        {
            int ch = 10;
            switch (reader.GetDataTypeName(i))
            {
                case "Int32":ch=8; break;
            }
            dataLine.Append($"{reader.GetValue(i).ToString().PadLeft(ch)}");
        }

        Console.WriteLine(dataLine.ToString());
    }
    reader.Close();

    var parFilter = 2;
    // param
    command = connection.CreateCommand();
    command.CommandText = "select count(Id) from [Student] where birthday < '01.02.2000' ";
    count = command.ExecuteScalar();
    Console.WriteLine($"Count = {count}");


    connection.Close();
}
 