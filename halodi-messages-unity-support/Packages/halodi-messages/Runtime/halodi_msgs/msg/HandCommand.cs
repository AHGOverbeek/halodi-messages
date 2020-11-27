using System.Text;
namespace halodi_msgs.msg
{


/**
          * Command to send to a hand
          *
          */
[System.Serializable]
public class HandCommand : Halodi.CDR.DataType<HandCommand>
{

	public Halodi.CDR.TopicDataType<HandCommand> Type => new HandCommandPubSubType();
	
   /**
                 * Closure ratio. 
                 * 
                 * Range: 0.0 - 1.0
                 *
                 */
   public double closure;
   /**
                 * (optional) Maximum relative velocity to move with. 
                 * 
                 * Range: 0.0 - 1.0
                 *
                 */
   public double velocity;
   /**
                 * (optional) Maximum relative force to apply.
                 * 
                 * Range: 0.0 - 1.0
                 *
                 */
   public double force;


   public void Set(HandCommand other)
   {
      closure = other.closure;

      velocity = other.velocity;

      force = other.force;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("HandCommand {");
      builder.Append("closure=");
      builder.Append(this.closure);      builder.Append(", ");
      builder.Append("velocity=");
      builder.Append(this.velocity);      builder.Append(", ");
      builder.Append("force=");
      builder.Append(this.force);
      builder.Append("}");
      return builder.ToString();
   }
}


}