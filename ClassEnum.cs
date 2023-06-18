using System.ComponentModel;
using System.Reflection;


namespace ProjetoDevSistemas2023Vini;


public enum EnumFuncionarioGrupo
    {
        [Description("Administrador")]
        Admin = 1,
        [Description("Atendente")]
        Atende = 2,
        [Description("Entregador")]
        Entrega = 3,
    }

public enum EnumValorTamanho
{
    [Description("Pequena")]
    Pequena = 'P',
    [Description("Média")]
    Media = 'M',
    [Description("Grande")]
    Grande = 'G',
    [Description("Família")]
    Familia = 'F'
}

public enum EnumBorda
{
    [Description("Nao")]
    Nao = 'N',
    [Description("Cheddar")]
    Cheddar = 'C',
    [Description("Chocolate Preto")]
    Grande = 'P',
    [Description("Chocolate Branco")]
    Familia = 'B',
    [Description("Chocolate Catupity")]
    Catupiry = 'Y'
}

public enum EnumSaborCategoria
{
    [Description("Tradicional")]
    Tradicional = 'T',
    [Description("Especial")]
    Especial = 'E'
}
public enum EnumSaborTipo
{
    [Description("Doce")]
    Doce = 'D',
    [Description("Salgada")]
    Salgada = 'S'
}

public enum EnumProdutoTipo
{
    [Description("Nenhum")]
    Nenhum = 'N',
    [Description("Refrigerante")]
    Refrigerante = 'R',
    [Description("Cerveja")]
    Cerveja = 'C',
    [Description("Suco")]
    Suco = 'S',
    [Description("Água")]
    Agua = 'A',
    [Description("Outros")]
    Outros = 'O'
}

public enum EnumProdutoTamanho
{
    [Description("Nenhum")]
    Nenhum = 'N',
    [Description("150ML")]
    Pequena = 'P',
    [Description("300")]
    Media = 'M',
    [Description("600")]
    Grande = 'G',
    [Description("1000")]
    Litrao = 'L',
    [Description("2000")]
    Familia = 'F'

    // P = pequena, M = Media, G = Grande, L = litrao, F = Familia
}


public static class ClassEnum
    {
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }


    }



