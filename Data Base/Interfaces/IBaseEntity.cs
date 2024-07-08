namespace Data_Base.Interfaces;

public interface IBaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
}
