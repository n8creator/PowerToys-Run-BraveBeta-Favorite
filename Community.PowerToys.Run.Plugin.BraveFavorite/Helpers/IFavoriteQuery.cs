﻿// Copyright (c) Davide Giacometti, Dmitry Volkov. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Community.PowerToys.Run.Plugin.BraveFavorite.Models;

namespace Community.PowerToys.Run.Plugin.BraveFavorite.Helpers
{
    public interface IFavoriteQuery
    {
        IEnumerable<FavoriteItem> GetAll(FavoriteItem node);

        IEnumerable<FavoriteItem> Search(FavoriteItem node, string[] path, int depth);
    }
}
