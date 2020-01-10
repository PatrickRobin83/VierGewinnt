namespace VierGewinnt.Core.Interfaces
{
    public  interface IFieldFactory
    {
        IField Create(int columnIndex, int rowIndex);
    }
}