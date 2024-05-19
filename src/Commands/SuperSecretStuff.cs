/*
Copyright (C) 2024 Dea Brcka

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System.Runtime.InteropServices;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;


namespace SharpTimer
{
    public partial class SharpTimer
    {
        /* [ConsoleCommand("css_rename", "RenamePlayer")]
        [CommandHelper(whoCanExecute: CommandUsage.CLIENT_ONLY)]
        public void Rename(CCSPlayerController? player, CommandInfo command)
        {
            if (player == null || !player.IsValid || string.IsNullOrEmpty(command.GetArg(1)))
                return;

            ChangePlayerName(player, command.GetArg(1));
        }

        [ConsoleCommand("css_setvm", "SetViewModel")]
        [CommandHelper(whoCanExecute: CommandUsage.CLIENT_ONLY)]
        public void ChangeViewModel(CCSPlayerController? player, CommandInfo command)
        {
            if (player == null || !player.IsValid)
                return;

            if (player.Pawn == null || !player.Pawn.IsValid)
                return;

            if (player.Pawn.Value == null || !player.Pawn.Value.IsValid)
                return;

            var arg = command.GetArg(1);

            CHandle<CBaseViewModel>[]? viewModels = GetPlayerViewModels(player);

            if (viewModels == null)
                return;

            CHandle<CBaseViewModel>? viewModel = viewModels[0];

            if (viewModel != null && viewModel.IsValid && viewModel.Value != null && viewModel.IsValid)
            {
                SharpTimerDebug("{0}" + viewModel.Value.VMName);
                viewModel.Value.SetModel(arg);
            }
        }

        private static unsafe CHandle<CBaseViewModel>[]? GetPlayerViewModels(CCSPlayerController player)
        {
            CCSPlayerPawn pawn = player.Pawn.Value!.As<CCSPlayerPawn>();

            if (pawn.ViewModelServices == null || pawn.ViewModelServices.Handle == IntPtr.Zero)
                return null;

            CCSPlayer_ViewModelServices viewModelServices = new CCSPlayer_ViewModelServices(pawn.ViewModelServices.Handle);
            return ESchema.GetFixedArray<CHandle<CBaseViewModel>>(viewModelServices.Handle, "CCSPlayer_ViewModelServices", "m_hViewModel", 3);
        }

        public unsafe static class ESchema
        {
            public static unsafe T[] GetFixedArray<T>(nint pointer, string @class, string member, int length)
            {
                nint ptr = pointer + Schema.GetSchemaOffset(@class, member);
                Span<nint> references = MemoryMarshal.CreateSpan<nint>(ref ptr, length);
                T[] values = new T[length];

                for (int i = 0; i < length; i++)
                {
                    values[i] = (T)Activator.CreateInstance(typeof(T), references[i])!;
                }

                return values;
            }
        } */
    }
}
