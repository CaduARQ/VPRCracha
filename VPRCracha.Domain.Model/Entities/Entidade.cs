namespace VPRCracha.Domain.Model.Entidades
{
    public class Entidade<TEntidade> where TEntidade : class
    {
        public Entidade()
        {
            
        }

        public Entidade(int pID):this()
        {
            this.ID = pID;
        }

        public virtual int ID { get; private set; }

        public override bool Equals(object obj)
        {
            if (obj is TEntidade)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}