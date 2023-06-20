using System.Data;
using System.Reflection;

namespace AdoNet.Web.Framework
{
    public class DatatableConvertToList
    {
        public static List<T> DataTableToList<T>(DataTable dataTable) where T : new()
        {
            List<T> list = new List<T>();

            foreach (DataRow row in dataTable.Rows)
            {
                T obj = new T();

                foreach (DataColumn column in dataTable.Columns)
                {
                    PropertyInfo property = obj.GetType().GetProperty(column.ColumnName);

                    if (property != null && row[column] != DBNull.Value)
                    {
                        property.SetValue(obj, row[column]);
                    }
                }

                list.Add(obj);
            }

            return list;
        }
    }
}
