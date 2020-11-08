namespace WurmCookingHelper.Data.Models
{
    public class Affinity
    {
        public int Id { get; }

        public string Name { get;  }

        public Affinity(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
