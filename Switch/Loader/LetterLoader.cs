using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Switch.Collections;
using Switch.Letters;
using Switch.Writter;

namespace Switch.Loader
{
    public class LetterLoader : ILetterLoader
    {
        private readonly IOutputWritter writter;
        public LetterLoader(IOutputWritter writter)
        {

            if (writter == null)
            {
                throw new ArgumentNullException(nameof(writter));
            }

            this.writter = writter;
        }

        public ILetterCollection Load()
        {
            List<ILetter> list = new List<ILetter>();

            var path = AppDomain.CurrentDomain.BaseDirectory;
            var name = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            path += name+".exe"; 
            Assembly ptrAssembly = Assembly.LoadFile(path);

            foreach (Type item in ptrAssembly.GetTypes())
            {
                if (!item.IsClass || item.IsAbstract) continue;
                if (item.GetInterfaces().Contains(typeof(ILetter)))
                {
                    Type[] argTypes = new Type[] { typeof (ConsoleWritter) };
                    ConstructorInfo cInfo = item.GetConstructor(argTypes);
                    if(cInfo != null)
                        list.Add((ILetter)cInfo.Invoke(new object[] { this.writter }));
                }
            }

            ILetterCollection collection = new LetterCollection(list);

            return collection;
        }
    }
}
