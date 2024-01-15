

namespace RestApiModeloDDD.Domain.Entitys
{
    public class Base
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public string Nome { get; set; }
        public Guid Id { get; set; }
    }
}
