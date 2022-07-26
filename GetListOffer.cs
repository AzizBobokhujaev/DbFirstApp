using DbFirstApp.Models.Entities;

namespace DbFirstApp;

public class GetListOffer
{
    public ulong Id { get; set; }
    public ulong ProductId { get; set; }
    public ulong PartnerId { get; set; }
    public ulong Quantity { get; set; }
    public ulong Price { get; set; }
    public ulong OldPrice { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; } 
    public bool IsVisible { get; set; }
    public virtual Product Product { get; set; }
    public virtual Partner Partner { get; set; }
    public virtual Condition Condition { get; set; }
}