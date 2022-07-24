using ProtoBuf;

namespace ProtobufNet6.Models
{
    [ProtoContract]
    public class Pessoa
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string Nome { get; set; }

        [ProtoMember(3)]
        public Endereco Endereco { get; set; }

        [ProtoIgnore]
        public bool Ativo { get; set; }
    }
}
