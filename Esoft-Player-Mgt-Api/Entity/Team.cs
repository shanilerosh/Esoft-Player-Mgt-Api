namespace Esoft_Player_Mgt_Api.Entity
{
    public class Team
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public string Owner { get; set; } = "";

        public string State { get; set; } = "";

        public virtual ICollection<Player> Players { get; set; }

    }
}
