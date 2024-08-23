using Coordinator.Enums;

namespace Coordinator.Models;

public record NodeState(Guid TransactionId)
{
    public Guid Id { get; set; }

    /// <summary>
    /// 1. ashamanin durumunu ifade ediyor
    /// </summary>
    public ReadyType IsReady { get; set; }

    /// <summary>
    /// 2. ashamanin neticesinde ishlemin basharili tamamlandigini ifade edir.
    /// </summary>
    public TransactionState TransactionState { get; set; }
    public Node Node { get; set; }
}