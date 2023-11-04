using GameFramework.Procedure;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using GameFramework;

namespace GDT
{
    /// <summary>
    /// 测试流程
    /// </summary>
    public class ProcedureTest : ProcedureBase
    {

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            Log.Info("This is test procedure");
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        }
    }
}
