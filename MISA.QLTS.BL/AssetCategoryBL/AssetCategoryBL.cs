﻿using MISA.QLTS.Common.Entities;
using MISA.QLTS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.QLTS.BL.AssetCategoryBL
{
    public class AssetCategoryBL : BaseBL<fixed_asset_category>, IAssetCategoryBL
    {
        #region Field

        private IAssetCategoryDL _assetCategoryDL;

        #endregion

        #region Constructor

        public AssetCategoryBL(IAssetCategoryDL assetCategoryDL) : base(assetCategoryDL)
        {
            _assetCategoryDL = assetCategoryDL;
        }

        #endregion

        #region Method



        #endregion
    }
}
