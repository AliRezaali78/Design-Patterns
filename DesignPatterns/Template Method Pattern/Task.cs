namespace DesignPatterns.Template_Method_Pattern
{
    public abstract class Task
    {
        private readonly AuditManager _auditManager = new AuditManager();

        public void Execute()
        {
            _auditManager.Record();

            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
