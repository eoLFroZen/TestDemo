public class Author
{
	public string Name {get;set;}
	public int Age {get; set; }
	
	
	public string IntroduceYourself()
	{
		return $"{Name} - {Age}";
	}
}