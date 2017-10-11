using System.Runtime.Serialization;

namespace Model.Dto
{
    [DataContract]
    public class User
    {
        [DataMember]
        private int id;

        public User(int id)
        {
            this.id = id;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Id 
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
