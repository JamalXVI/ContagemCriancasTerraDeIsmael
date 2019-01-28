using System;
using System.Globalization;

namespace ContagemCriancas.Utils
{
    public static class DataUtils
    {
        #region Formatadores
        public static DateTime FormartarNoFormatoPadrao(string dataParaConverter)
        {
            return DateTime.ParseExact(dataParaConverter, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        public static DateTime FormartarSomenteHora(string dataParaConverter)
        {
            return DateTime.ParseExact(dataParaConverter, "HH:mm", CultureInfo.InvariantCulture);
        }
        #endregion
        #region Conversores
        public static String ConverterDataParaString(DateTime data)
        {
            return data.ToString("yyyy-MM-dd",CultureInfo.InvariantCulture);
        }
        public static String ConverterHoraParaString(DateTime data)
        {
            return data.ToString("HH:mm", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}