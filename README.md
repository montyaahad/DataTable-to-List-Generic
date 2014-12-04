DataTable to List using Generic
===============================

DataTable to List converter generic class.
Convert `DataTable` to a specific class `List<>`.
The Class Property Name must be same as the Column Name of the `DataTable`.
**The mapping is directly upon "Class Property Name" and "Column Name of the DataTable".**

Suppose, we have a `DataTable` containing Students data.

```
DataTable dtStudent = GetDataTable();

.......

static DataTable GetDataTable()
{
    // Here we create a DataTable with four columns.
    DataTable table = new DataTable();
    table.Columns.Add("Name", typeof(string));
    table.Columns.Add("Roll", typeof(string));

    // Here we add five DataRows.
    table.Rows.Add("David", "a-100");
    table.Rows.Add("Sam", "a-101");
    table.Rows.Add("Christoff", "a-102");
    table.Rows.Add("Janet", "a-103");
    table.Rows.Add("Melanie", "a-104");

    return table;
}
```

Now, I'm not comfortable with this `DataTable` :) So, lets convert this `dtStudent` to `List<Student>`.

Simply call this - 
```
List<Student> listStudents = DataTableToListLib.DataTableToList.Convert<Student>(dtStudent);
........
public class Student
{
    public string Name { get; set; }
    public string Roll { get; set; }
}
```

The important part is - ***The mapping is directly upon `Student Class Property Name` and `Column Name of the DataTable`.***

Here, `Name` and `Roll` in both `Student` class and `DataTable` column maps each other. So these properties must has to be same with spelling too.
