namespace DevCard___MVC.Models
{
	// in contact model , ServiceItems property need a list
	// these model used to fill up that list and show it
	// in drop down list

	public class SerivceName
	{
		public int Id { get; set; }
        public string Name { get; set; }

        public SerivceName(int id , string name)
        {
            Id = id ;
            Name = name ;
        }
    }
}
