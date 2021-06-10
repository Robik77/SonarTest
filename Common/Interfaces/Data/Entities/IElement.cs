namespace Data.Entities
{
    public interface IElement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IAttribute Attribute { get; set; }
        public string Description { get; set; }
        public IBlock Block { get; set; }
    }
}
