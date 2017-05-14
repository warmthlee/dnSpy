﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.ComponentModel.Composition;
using dnSpy.Contracts.ToolWindows.App;
using dnSpy.Debugger.Properties;
using dnSpy.Debugger.ToolWindows.Locals.Shared;

namespace dnSpy.Debugger.ToolWindows.Autos {
	[Export(typeof(IToolWindowContentProvider))]
	sealed class AutosToolWindowContentProvider : LocalsToolWindowContentProviderBase {
		public static readonly Guid THE_GUID = new Guid("6E0232EC-3D88-4087-A571-CC1184D86645");
		[ImportingConstructor]
		AutosToolWindowContentProvider(Lazy<AutosContent> autosContent)
			: base(THE_GUID, AppToolWindowConstants.DEFAULT_CONTENT_ORDER_BOTTOM_DEBUGGER_AUTOS, dnSpy_Debugger_Resources.Window_Autos, new Lazy<ILocalsContent>(() => autosContent.Value)) { }
	}
}