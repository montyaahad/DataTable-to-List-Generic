using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace DataTableToListLib
{
    /// <summary>
    /// DataTable to List converter generic class.
    /// Convert DataTable to a specific class List<>.
    /// The Class Property Name must be same as the Column Name of the DataTable.
    /// The mapping is directly upon "Class Property Name" and "Column Name of the DataTable".
    /// </summary>
    public class DataTableToList
    {
        public static List<T> Convert<T>(DataTable table)
            where T : class, new()
        {
            List<Tuple<DataColumn, PropertyInfo>> map =
                new List<Tuple<DataColumn, PropertyInfo>>();

            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                //ColumnAttribute col = (ColumnAttribute)
                //    Attribute.GetCustomAttribute(pi, typeof(ColumnAttribute));
                //if (col == null) continue;
                if (table.Columns.Contains(pi.Name))
                {
                    map.Add(new Tuple<DataColumn, PropertyInfo>(
                        table.Columns[pi.Name], pi));
                }
            }

            List<T> list = new List<T>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                if (row == null)
                {
                    list.Add(null);
                    continue;
                }
                T item = new T();
                foreach (Tuple<DataColumn, PropertyInfo> pair in map)
                {
                    object value = row[pair.Value1];
                    if (value is DBNull) value = null;
                    pair.Value2.SetValue(item, value, null);
                }
                list.Add(item);
            }
            return list;
        }
    }

    sealed class Tuple<T1, T2>
    {
        public Tuple() { }
        public Tuple(T1 value1, T2 value2) { Value1 = value1; Value2 = value2; }
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }
    }
}
