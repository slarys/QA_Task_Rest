namespace QA_Task;

public class Restaurant 
{
    public Restaurant()
    {
    }

    public Restaurant( string chefName, string name,double fee)
    {
        ChefName = chefName;
        Name = name;
        Fee = fee;
    }
    
    public Restaurant( string chefName, string name,double fee,List<Dish> listDishes)
    {
        
        ChefName = chefName;
        Name = name;
        Fee = fee;
        this.listDishes = listDishes;
    }



    public List<Dish> listDishes { get; set; }
    public string ChefName { get; set; }
    public string Name { get; set; }
    public double Fee { get; set; }
    
    
}