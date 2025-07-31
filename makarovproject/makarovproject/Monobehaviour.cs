using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace makarovproject
{
    public abstract class Monobehaviour
    {
        private Thread t;
        private bool active = true;
        public bool visible = false;
        public bool input = false;

        public void Run()
        {
            Awake();
            Start();
            t = new Thread(
                () => {
                while (active)
                    {
                        Update();
                        LateUpdate();                        
                        Thread.Sleep(80);                        
                    }                    
                }
            );
            t.Start();
        }

        public void Stop()
        {
            this.active = false;
            OnDestroy();
            t.Join();
        }

        public virtual void Awake() { }
        public virtual void Start() { }
        public virtual void Update() { }
        public virtual void LateUpdate() { }
        public virtual void OnDestroy() { }
        public abstract void Draw();
    }
}
