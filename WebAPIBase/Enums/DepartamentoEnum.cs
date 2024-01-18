using System.Text.Json.Serialization;

namespace WebAPIBase.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartamentoEnum
    {
        RH,
        FINANCEIRO,
        COMPRAS,
        ATENDIMENTO,
        ZELADORIA
    }
}
