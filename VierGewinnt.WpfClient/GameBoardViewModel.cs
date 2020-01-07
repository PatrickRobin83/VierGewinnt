using System;
using System.Collections.Generic;
using VierGewinnt.Core;
using VierGewinnt.WpfClient.Annotations;

namespace VierGewinnt.WpfClient
{
    public class GameBoardViewModel : IGameBoardViewModel
    {
        private readonly IReadOnlyList<IField>  _fields;
        private readonly IReadOnlyList<IClickColumnsCommand>  _clickColumnsCommands;

        public GameBoardViewModel([NotNull] IReadOnlyList<IField> fields, [NotNull] IReadOnlyList<IClickColumnsCommand> clickColumnsCommands)
        {
            _fields = fields ?? throw new ArgumentNullException(nameof(fields));
            _clickColumnsCommands = clickColumnsCommands ?? throw new ArgumentNullException(nameof(clickColumnsCommands));
        }

        public IReadOnlyList<IField> Fields => _fields;
        public IReadOnlyList<IClickColumnsCommand> ClickColumnsCommands => _clickColumnsCommands;
    }
}