namespace ApiEcommerce.Models.Repository;

public interface ICategoryRepository
{
    ICollection<Category> GetCategories();
    Category GetCategory(int id);
    bool CategoryExists(int id);
    bool CategoryExists(string id);
    bool CreateCategory(Category category);
    bool UpdateCategory(Category category);
    bool DeleteCategory(Category category);
    bool Save();
}
