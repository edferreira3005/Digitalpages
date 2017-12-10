using SQLite.Net.Attributes;

namespace AndroidDP.Core.Model
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
