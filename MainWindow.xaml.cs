using porjekt;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPFCharacterEditor
{
    public partial class MainWindow : Window
    {
        private Character _character = new Character();
        private EquipmentManager _equipmentManager = new EquipmentManager();

        private int _currentHelmetIndex = 0;
        private int _currentChestplateIndex = 0;
        private int _currentPantsIndex = 0;
        private int _currentBootsIndex = 0;
        private int _currentWeaponIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            EquipDefaultItems();
            UpdateUI();
        }

        private void EquipDefaultItems()
        {
            _character.EquipHelmet(_equipmentManager.Helmets[_currentHelmetIndex]);
            _character.EquipChestplate(_equipmentManager.Chestplates[_currentChestplateIndex]);
            _character.EquipPants(_equipmentManager.Pants[_currentPantsIndex]);
            _character.EquipBoots(_equipmentManager.Boots[_currentBootsIndex]);
            _character.EquipWeapon(_equipmentManager.Weapons[_currentWeaponIndex]);
        }

        private void UpdateUI()
        {
            // Aktualizuj obrázky
            HelmetImage.Source = new BitmapImage(new Uri(_character.CurrentHelmet.ImagePath, UriKind.Relative));
            ChestplateImage.Source = new BitmapImage(new Uri(_character.CurrentChestplate.ImagePath, UriKind.Relative));
            PantsImage.Source = new BitmapImage(new Uri(_character.CurrentPants.ImagePath, UriKind.Relative));
            BootsImage.Source = new BitmapImage(new Uri(_character.CurrentBoots.ImagePath, UriKind.Relative));
            WeaponImage.Source = new BitmapImage(new Uri(_character.CurrentWeapon.ImagePath, UriKind.Relative));

            // Aktualizuj statistiky
            StatDefense.Text = $"Obrana: {_character.TotalDefense}";
            StatAttack.Text = $"Útok: {_character.TotalAttack}";
            StatSpeed.Text = $"Rychlost: {_character.TotalSpeed}";
        }

        // Tlačítka pro Helmet
        private void PrevHelmet_Click(object sender, RoutedEventArgs e)
        {
            _currentHelmetIndex = (_currentHelmetIndex - 1 + _equipmentManager.Helmets.Count) % _equipmentManager.Helmets.Count;
            _character.EquipHelmet(_equipmentManager.Helmets[_currentHelmetIndex]);
            UpdateUI();
        }

        private void NextHelmet_Click(object sender, RoutedEventArgs e)
        {
            _currentHelmetIndex = (_currentHelmetIndex + 1) % _equipmentManager.Helmets.Count;
            _character.EquipHelmet(_equipmentManager.Helmets[_currentHelmetIndex]);
            UpdateUI();
        }

        // Tlačítka pro Chestplate
        private void PrevChestplate_Click(object sender, RoutedEventArgs e)
        {
            _currentChestplateIndex = (_currentChestplateIndex - 1 + _equipmentManager.Chestplates.Count) % _equipmentManager.Chestplates.Count;
            _character.EquipChestplate(_equipmentManager.Chestplates[_currentChestplateIndex]);
            UpdateUI();
        }

        private void NextChestplate_Click(object sender, RoutedEventArgs e)
        {
            _currentChestplateIndex = (_currentChestplateIndex + 1) % _equipmentManager.Chestplates.Count;
            _character.EquipChestplate(_equipmentManager.Chestplates[_currentChestplateIndex]);
            UpdateUI();
        }

        // Tlačítka pro Pants
        private void PrevPants_Click(object sender, RoutedEventArgs e)
        {
            _currentPantsIndex = (_currentPantsIndex - 1 + _equipmentManager.Pants.Count) % _equipmentManager.Pants.Count;
            _character.EquipPants(_equipmentManager.Pants[_currentPantsIndex]);
            UpdateUI();
        }

        private void NextPants_Click(object sender, RoutedEventArgs e)
        {
            _currentPantsIndex = (_currentPantsIndex + 1) % _equipmentManager.Pants.Count;
            _character.EquipPants(_equipmentManager.Pants[_currentPantsIndex]);
            UpdateUI();
        }

        // Tlačítka pro Boots
        private void PrevBoots_Click(object sender, RoutedEventArgs e)
        {
            _currentBootsIndex = (_currentBootsIndex - 1 + _equipmentManager.Boots.Count) % _equipmentManager.Boots.Count;
            _character.EquipBoots(_equipmentManager.Boots[_currentBootsIndex]);
            UpdateUI();
        }

        private void NextBoots_Click(object sender, RoutedEventArgs e)
        {
            _currentBootsIndex = (_currentBootsIndex + 1) % _equipmentManager.Boots.Count;
            _character.EquipBoots(_equipmentManager.Boots[_currentBootsIndex]);
            UpdateUI();
        }

        // Tlačítka pro Weapon
        private void PrevWeapon_Click(object sender, RoutedEventArgs e)
        {
            _currentWeaponIndex = (_currentWeaponIndex - 1 + _equipmentManager.Weapons.Count) % _equipmentManager.Weapons.Count;
            _character.EquipWeapon(_equipmentManager.Weapons[_currentWeaponIndex]);
            UpdateUI();
        }

        private void NextWeapon_Click(object sender, RoutedEventArgs e)
        {
            _currentWeaponIndex = (_currentWeaponIndex + 1) % _equipmentManager.Weapons.Count;
            _character.EquipWeapon(_equipmentManager.Weapons[_currentWeaponIndex]);
            UpdateUI();
        }
        private void random_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            _currentHelmetIndex = rnd.Next(0, _equipmentManager.Helmets.Count);
            _character.EquipHelmet(_equipmentManager.Helmets[_currentHelmetIndex]);

            _currentChestplateIndex = rnd.Next(0, _equipmentManager.Chestplates.Count);
            _character.EquipChestplate(_equipmentManager.Chestplates[_currentChestplateIndex]);

            _currentPantsIndex = rnd.Next(0, _equipmentManager.Pants.Count);
            _character.EquipPants(_equipmentManager.Pants[_currentPantsIndex]);

            _currentBootsIndex = rnd.Next(0, _equipmentManager.Boots.Count);
            _character.EquipBoots(_equipmentManager.Boots[_currentBootsIndex]);

            _currentWeaponIndex = rnd.Next(0, _equipmentManager.Weapons.Count);
            _character.EquipWeapon(_equipmentManager.Weapons[_currentWeaponIndex]);

            UpdateUI();
        }
    }
}
