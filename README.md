# KSBScriptLib
The lib used in the C# script-engine currently implemented in KSB. This lib provides an interface/basic functionality that can be used within scripts and sample script for reference.
***
### Purpose
Promote better understanding of the script engine that will be expanded and utilized for KSB, while also providing an interface for various function support. All commands that are in this lib will be supported by KSB.

### Future
 * Add proper XML documentation for each method.
 * Provide more sample-scripts and situational examples.

### Features
 * Basic functionality to support Tower01.

### Usage
#### Existing Project
1. Create a new .cs file appropriately named (eg: Tower02.cs)
2. Copy/paste the shell into the new class
  * **Note: Rename the class to that of your script (the example is for Tower02)**
3. Build your script following normal C# standards
  * **Note: Refrain from using any external libs or namespaces, if you have to create a reference or using tag, you're adding unsupported functionality**

#### New Project
1. Download the latest lib or clone/rebuild from source
2. Attach to a fresh project (can be using any IDE) as a reference
3. Create a new .cs file appropriately named (eg: Tower02.cs)
4. Copy/paste the shell into the new class
  * **Note: Rename the class to that of your script (the example is for Tower02)**
5. Build your script following normal C# standards
  * **Note: Refrain from using any external libs or namespaces, if you have to create a reference or using tag, you're adding unsupported functionality**

### Shell
```csharp
using KSB_ScriptLib.Structure;

namespace KSBCSScript
{
    public class Tower02 : CSScript
    {
        public void Construct(long now)
        {

        }

        public void Start(dynamic owner, long now)
        {

        }

        public void Reset(dynamic owner, long now)
        {
            this[owner.Handle] = null;
        }

        public void Stop(dynamic owner, long now)
        {
            
        }

        public void Destruct(long now)
        {

        }

        public object Main(dynamic owner, long now)
        {
            dynamic var = this[owner.Handle];

            if (var == null)
            {
                this[owner.Handle] = new CSScriptObject();

                var = this[owner.Handle];
                var.Owner = owner;
            }

            return eScriptLoopType.SLT_RETURN;
        }
    }
}
``` 
