using System.Text.Json.Serialization;

namespace WebAPIBase.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnoEnum
    {   
        MANHA, 
        TARDE,
        NOITE
    }
}
