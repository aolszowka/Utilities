using ReactiveUI;

using Samer.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;

namespace Samer.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            IsCaseSensitiveCompare = true;
            _inputLeft = string.Empty;
            _inputRight = string.Empty;
            _output = string.Empty;
            ComparisonTypeList = Enum.GetValues(typeof(ComparisonType)).Cast<ComparisonType>().ToArray();
            ComparisonType = ComparisonType.Common;

            ProcessInputs = ReactiveCommand.Create(InternalProcessInputs);
            this
                .WhenAnyValue(x => x.InputLeft, x => x.InputRight, x=>x.IsCaseSensitiveCompare, x=>x.ComparisonType)
                .Select(_ => Unit.Default)
                .InvokeCommand(ProcessInputs);
        }

        private string _inputLeft;
        public string InputLeft
        {
            get => _inputLeft;
            set => this.RaiseAndSetIfChanged(ref _inputLeft, value);
        }
        private string _inputRight;
        public string InputRight
        {
            get => _inputRight;
            set => this.RaiseAndSetIfChanged(ref _inputRight, value);
        }
        private string _output;
        public string Output
        {
            get => _output;
            set => this.RaiseAndSetIfChanged(ref _output, value);
        }
        private bool _isCaseSensitiveCompare;
        public bool IsCaseSensitiveCompare
        {
            get => _isCaseSensitiveCompare;
            private set => this.RaiseAndSetIfChanged(ref _isCaseSensitiveCompare, value);
        }
        private ComparisonType _comparisonType;
        public ComparisonType ComparisonType
        {
            get => _comparisonType;
            set => this.RaiseAndSetIfChanged(ref _comparisonType, value);
        }

        public ComparisonType[] ComparisonTypeList { get; }

        public ReactiveCommand<Unit, Unit> ProcessInputs { get; }

        void InternalProcessInputs()
        {
            if (!string.IsNullOrWhiteSpace(InputLeft) && !string.IsNullOrWhiteSpace(InputRight))
            {
                StringComparer compareType = StringComparer.CurrentCultureIgnoreCase;
                if (IsCaseSensitiveCompare)
                {
                    compareType = StringComparer.CurrentCulture;
                }

                HashSet<string> leftInputs = new HashSet<string>(compareType);
                leftInputs.UnionWith(InputLeft.Split(Environment.NewLine));
                HashSet<string> rightInputs = new HashSet<string>(compareType);
                rightInputs.UnionWith(InputRight.Split(Environment.NewLine));

                switch(this.ComparisonType)
                {
                    case ComparisonType.Common:
                        {
                            leftInputs.IntersectWith(rightInputs);
                            Output = string.Join(Environment.NewLine, leftInputs.ToArray());
                            break;
                        }
                    case ComparisonType.LeftUnique:
                        {
                            leftInputs.ExceptWith(rightInputs);
                            Output = string.Join(Environment.NewLine, leftInputs.ToArray());
                            break;
                        }
                    case ComparisonType.RightUnique:
                        {
                            rightInputs.ExceptWith(leftInputs);
                            Output = string.Join(Environment.NewLine, rightInputs.ToArray());
                            break;
                        }
                }
            }
        }
    }
}
