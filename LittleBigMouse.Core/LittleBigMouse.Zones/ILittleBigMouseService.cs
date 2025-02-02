﻿/*
  LittleBigMouse.Screen.Config
  Copyright (c) 2021 Mathieu GRENET.  All right reserved.

  This file is part of LittleBigMouse.Screen.Config.

    LittleBigMouse.Screen.Config is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LittleBigMouse.Screen.Config is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MouseControl.  If not, see <http://www.gnu.org/licenses/>.

	  mailto:mathieu@mgth.fr
	  http://www.mgth.fr
*/

namespace LittleBigMouse.Zoning;

public enum LittleBigMouseState
{
    Running,
    Stopped,
    Dead,
}
public enum LittleBigMouseCommand
{
    Load,
    Run,
    Stop,
    Quit
}


public class CommandMessage : IZonesSerializable
{
    public CommandMessage()
    {
    }
    public CommandMessage(LittleBigMouseCommand command)
    {
        Command = command;
    }

    public CommandMessage(LittleBigMouseCommand command, ZonesLayout payload)
    {
        Command = command;
        Payload = payload;
    }
    public LittleBigMouseCommand Command { get; set; }
    public ZonesLayout? Payload { get; set; }

    public string Serialize()
    {
        return ZoneSerializer.Serialize(this,e => e.Command, e => e.Payload);
    }
}


public interface ILittleBigMouseService
{
    Task QuitAsync(CancellationToken token = default);
    Task StartAsync(ZonesLayout zonesLayout, CancellationToken token = default);
    //Func<ZonesLayout?> ZonesLayoutGetter { get; set; }
    Task StopAsync(CancellationToken token = default);
    Task CommandLineAsync(IList<string> args, CancellationToken token = default);
}