namespace RecipeApi.Models
{
    public class RecipeItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}
        public int IngredientId {get; set;}
        public string Instructions {get; set;}
        public string Date {get; set;}

    }

    public class RecipeItemDTO
    {

        public RecipeItemDTO(){}
        public RecipeItemDTO(RecipeItem recipeItem){
            Id= recipeItem.Id;
            Name= recipeItem.Name;
            Description = recipeItem.Description;
            IngredientId = recipeItem.IngredientId;
            Instructions = recipeItem.Instructions;
            Date = recipeItem.Date;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}
        public int IngredientId {get; set;}
        public string Instructions {get; set;}
        public string Date {get; set;}
    }
}

