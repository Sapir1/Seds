using Godot;
using System;

public class platform : Node
{
    public void _on_platform_body_entered(PhysicsBody2D body)
    {

        if(body.HasMethod("AllowMove") && body.HasMethod("StartWoahThereing")) 
        {
            body.Call("AllowMove");
            body.Call("StartWoahThereing");
        }

    }

    public void _on_platform_body_exited(PhysicsBody2D body)
    {
        if(body.HasMethod("DisallowMove")) 
        {
            body.Call("DisallowMove");
            body.Call("StopWoahThereing");
        }
    }
  
}
