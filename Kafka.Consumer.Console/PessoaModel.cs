using System.Text.Json.Serialization;

namespace Kafka.Consumer.Console
{
    public class PessoaModel
    {
        [JsonPropertyName("Nome")]
        public string? Nome { get; set; }
        [JsonPropertyName("idade")]
        public int Idade { get; set; }
       
    public override string ToString()
    {
            return $"{this.Nome} tem {this.Idade} anos!";
    }
    }

}