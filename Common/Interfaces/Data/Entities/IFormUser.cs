namespace Data.Entities
{
    public interface IFormUser
    {
        public int FormId { get; set; }
        public IForm Form { get; set; }
        public int UserId { get; set; }
        public IUser User { get; set; }
    }
}
