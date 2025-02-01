﻿// Copyright (c) Davide Giacometti, Dmitry Volkov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Community.PowerToys.Run.Plugin.BraveFavorite.Models;

namespace Community.PowerToys.Run.Plugin.BraveFavorite.Helpers
{
    public interface IFavoriteProvider
    {
        FavoriteItem Root { get; }
    }
}
