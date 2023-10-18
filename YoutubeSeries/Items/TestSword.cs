using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YoutubeSeries.Items
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults() 
		{

			ItemID.Sets.ShimmerTransformToItem[base.Type] = ItemID.Dirtblock; //Shimmer Result
		}
		public override void SetDefaults()
		{
			Item.damage = 50;

			Item.DamageType = DamageClass.Melee;

			Item.width = 40;
			Item.height = 40;


			Item.useTime = 10;
			Item.useAnimation = 20;

			Item.useStyle = ItemUseStyleID.Swing;
			
			Item.knockBack = 6;

			Item.value = 10000;

			Item.rare = ItemRarityID.Master;

			Item.UseSound = SoundID.Item1;

			Item.autoReuse = true;
		}
	}
}