namespace VierGewinnt.Core
{
    public  interface IFieldFactory
    {
        IField Create(int columnIndex, int rowIndex);
    }
}