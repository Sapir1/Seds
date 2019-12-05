using Godot;
using System;


public class player : KinematicBody2D
{
    // Declare member variables here. Examples:
     Vector2 movement = new Vector2(); //mojimmy actually
     bool canmove = false;

     int remainingwoahthere = 0;

    
    
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {

    }

    public override void _PhysicsProcess(float delta) 
    {
        if(remainingwoahthere > 0)
        {
            -- remainingwoahthere;
            WoahThere();
        }
        if(canmove){
            if(Input.IsActionPressed("up"))
            {
                movement.y -= 1;
            }

            if(Input.IsActionPressed("down"))
            {
                movement.y += 1;
            }

            if(Input.IsActionPressed("left"))
            {
                movement.x -= 1;
            }

            if(Input.IsActionPressed("right"))
            {
                movement.x += 1;
            }
        }
        MoveAndSlide(10*movement);
    }
    public void AllowMove()
    {
        canmove = true;
    }

    public void DisallowMove()
    {
        canmove = false;
    }

    public void StopRightThereCriminalIThink()
    {
        movement.x = 0;
        movement.y = 0;
    }

    public void WoahThere()
    {
        if(movement.x > 10 || movement.x < -10) 
        {
            movement.x /= 1.03f;
        }
        else
        {
            movement.x = 0;
        }

        if(movement.y > 10 || movement.y < -10) 
        {
            movement.y /= 1.03f;
        }
        else
        {
            movement.y = 0;
        }
    }

    public void StartWoahThereing()
    {
        remainingwoahthere = 70;
    }

    public void StopWoahThereing()
    {
        remainingwoahthere = 0;
    }
}
