// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Text;

Console.WriteLine("Hello, World!");



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

    command = connection.CreateCommand();
    command.CommandText = "select Id,bigintField,smallintField from [User]";
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


    connection.Close();
}
 