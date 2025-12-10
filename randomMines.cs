int create_random_number()
{
  Random rand = new Random();
  int randomNumber = rand.Next(0,2);
  return randomNumber;
}

void set_button_type()
{
  int randomNumber = create_random_number();
  //it is a bomb
  if( randomNumber == 1)
  {
     btn_2.BackgroundImage = Resources.Bomb;
    if (score != 0)
    {
      score = score - 1;
      lbl_score.Text = score.ToString();
    }
  }
  //it is a treasure
  else
  {
     btn_2.backgroundImage = Resource.pngtree_glittering_pirate_treasure_chest_overflowing_with_gold_coins_and_jewels_png_image_21025515;
     score = score + 1;
     lbl_score.Text = score.ToString();
  }
}

private void btn_1_Click(object sender, EventArgs e)
{
  set_button_type();
  btn_1.Enabled = false;
}
      

