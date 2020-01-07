using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public class FieldDecoratorFactory : IFieldFactory
    {
        public IField Create(int columnIndex, int rowIndex)
        {
            return new FieldNotifyingDecorator(new Field(columnIndex,rowIndex));

        }
    }
}
