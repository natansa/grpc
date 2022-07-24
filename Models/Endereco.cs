using ProtoBuf;

namespace ProtobufNet6.Models
{
    [ProtoContract]
    public class Endereco
    {
        [ProtoMember(1)]
        public string Logradouro { get; set; }

        [ProtoMember(2)]
        public string Cidade { get; set; }
    }
}