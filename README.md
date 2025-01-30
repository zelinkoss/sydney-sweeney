# WPF Character Editor

Tento projekt je jednoduchý WPF editor postavy, ve kterém lze měnit vybavení postavy (helma, zbroj, kalhoty, boty, zbraň) a sledovat změny statistik.

## Funkce
- Výběr různých částí vybavení
- Dynamická změna statistik postavy (útok, obrana, rychlost)
- Možnost náhodného výběru vybavení
- Přidání vlastního vybavení
- Ošetření chyb pomocí `try-catch`

## Požadavky
- .NET 6 nebo novější
- Visual Studio s podporou WPF

## Instalace
1. Naklonuj si repozitář:
   ```sh
   git clone https://github.com/tvoje-jmeno/wpf-character-editor.git
   ```
2. Otevři projekt ve Visual Studio.
3. Spusť aplikaci (F5).

## Použití
- Použij tlačítka pro změnu vybavení.
- Sleduj, jak se mění statistiky postavy.
- Přidej si vlastní vybavení v `EquipmentManager.cs`.

## Struktura projektu
```
WPFCharacterEditor/
│-- Images/                   # Obrázky pro postavu a vybavení
│-- Models/                   # Třídy pro vybavení a postavu
│   ├── Character.cs
│   ├── Equipment.cs
│   ├── EquipmentManager.cs
│   ├── Stats.cs
│-- Views/                    # XAML soubory
│   ├── MainWindow.xaml
│-- MainWindow.xaml.cs        # Logika aplikace
│-- App.xaml                  # Konfigurace aplikace
│-- README.md                 # Dokumentace
```

## Jak přidat vlastní vybavení
1. Otevři `EquipmentManager.cs`
2. Přidej nový kus vybavení do příslušné kategorie:
   ```csharp
   Helmets.Add(new Equipment("Mystická helma", "Images/MysticHelmet.png", 5, 2, -1));
   ```
3. Ujisti se, že obrázek existuje ve složce `Images/`
4. Spusť aplikaci a vyzkoušej si novou položku!

## Licence
Tento projekt je otevřený pod licencí MIT. Můžeš ho upravovat a používat dle libosti.

---

Pokud máš nějaké nápady na vylepšení, neváhej vytvořit pull request! 😊



<p align="left">[Intro]<br>Huh<br>Huh, huh, huh, huh<br>Huh, huh, huh, huh, huh, huh, huh<br>Huh, huh, huh, huh, huh, huh, huh<br><br>[Verse]<br>Promethazine habit, lean habit, codeine habit<br>Kickstand, yeah, biker, yeah, yeah, I'm leanin'<br>I chop the top off the McLaren, this ain't no Lamborghini<br>My white ho got big titties, she remind me of Sydney Sweeney<br>Sydney Sweeney, Sydney Sweeney<br>I rock that stick like it's a purse, yeah, my chopper swingin'<br>Like Sydney Sweeney, my stick have them titties underneath<br>Like Sydney Sweeney, my bitch titties big like double D<br>Emergency, emergency<br>Shawty just threw it back, she tryna hurt me<br>Yeah, yeah, yeah, shawty just threw it back, she tryna birth one<br>But I'm way too rich, yeah, for this bitch, no, I can't birth none<br>My swag way too sick, I need an IV, yeah, yeah<br>Cs in my pocket, but we throwin' Bs over here<br>I got designer habits, I got designer habits, I can't stop<br>I was fuckin' on your bitch in my Rick Owens socks<br>I was fuckin' on your bitch in my Rick Owens socks<br>I was fuckin' on your bitch in my Rick Owens socks<br>I was fuckin' on your bitch in my Rick Owens socks<br>My Rick Owens socks, my Rick Owens socks, yeah<br>See upcoming rap shows<br>Get tickets for your favorite artists<br><br>[Part II]<br><br>[Verse]<br>I'm off the G6, they don't know if I'm talkin' 'bout the pill or the plane<br>Iced out my mouth, went Alex Moss, I don't know none 'bout Johnny Dang<br>I got unlimited jewelry, I put a X on my chain<br>She got unlimited pussy, I'm 'bout to fuck her for hours<br>Switched up my flow, he can't keep up, that boy career goin' sour<br>Paris Fashion Week, she wanna fuck at the Eiffel Tower<br>Paris Fashion Week, a model ho 'bout to get devoured<br>She say she like my aesthetic, all gas, no brakes, I'm unleaded<br>If I fuck with you, then we locked in, yeah, we dreaded<br>She fuckin' with me, yeah, she rubbin', yeah, her hand through my dreads<br>Ain't repeatin' shit after I speak, bitch, I mean what I said<br>I can buy fifteen Richie Mills, why would I cop a Rolex?</p>

###
