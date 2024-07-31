using System.Text;

namespace Design_Patterns_in_C_.Exercise.Builder
{

    class Field
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"public {Type} {Name};";
        }
    }
    class Class
    {
        public string Name { get; set; }
        public List<Field> Fields { get; set; } = new List<Field>();
        public Class()
        {

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"public class {Name}").AppendLine("{");
            foreach (var field in Fields)
            {
                sb.AppendLine($"{field}");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
    public class CodeBuilder
    {
        private Class createClass = new Class();
        public CodeBuilder(string name)
        {
            createClass.Name = name;
        }
        public CodeBuilder AddFields(string name, string type)
        {
            createClass.Fields.Add(new Field { Name = name, Type = type });
            return this;
        }
        public override string ToString()
        {
            return createClass.ToString();
        }
    }
}
