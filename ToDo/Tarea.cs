namespace Tareas
{
    public class Tarea{
        private int _tareaId;
        private string _descri;
        private int _dura;

        public int tareaId{
            get => _tareaId;
            set => _tareaId = value;
        }
        public string descri{
            get => _descri;
            set => _descri = value;
        }
        public int dura{
            get => _dura;
            set => _dura = value;
        }    
        
        public Tarea(int tareaId, string descri, int dura){
            this.tareaId = tareaId;
            this.descri = descri;
            this.dura = dura;
        }
        


    }
}