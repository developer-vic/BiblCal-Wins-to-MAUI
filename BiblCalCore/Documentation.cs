namespace BiblCalCore
{
    /// <summary>
    /// Documentation and help text for the Biblical Calendar application
    /// Adapted from modDocumentation.cs - matches Windows app behavior
    /// </summary>
    public static class Documentation
    {
        public const string Copyright = "                                Copyright 1986-2021";
        public const string Version = "Version 11.0";
        private const string CRLF = "\r\n";

        /// <summary>
        /// Gets documentation text for a specific mode
        /// </summary>
        public static string GetDocumentation(string mode)
        {
            return mode.ToLower() switch
            {
                "holydays" => GetHolyDaysDocumentation(),
                "localmoons" => GetLocalMoonsDocumentation(),
                "sunset" => GetSunsetDocumentation(),
                "jordan" => GetJordanDocumentation(),
                "flood" => GetFloodDocumentation(),
                "creation" => GetCreationDocumentation(),
                "golgotha" => GetGolgothaDocumentation(),
                "times" => GetTimesDocumentation(),
                "rabbinic" => GetRabbinicDocumentation(),
                "easter" => GetEasterDocumentation(),
                "conversions" => GetConversionsDocumentation(),
                _ => GetGeneralDocumentation()
            };
        }

        private static string GetHolyDaysDocumentation()
        {
            // Start with copyright and organization info (matches Windows app line 14)
            string instructions = Copyright + CRLF +
                   "                        Central Highlands Congregation of God" + CRLF +
                   "                        PO Box 236 Creswick Vic 3363   Australia" + CRLF +
                   "                      Phone 0428 457 363 Email info@chcpublications.net" + CRLF +
                   "       Permission is given to copy this program provided it is not altered and is" + CRLF +
                   "       given away. You may charge enough to cover media costs if necessary." + CRLF +
                   "       We have several other programs as well as a variety of documents available." + CRLF +
                   "       Please contact us for details or download them from our WEB site at" + CRLF +
                   "                               http://www.chcpublications.net" + CRLF + CRLF;
            
            // Continue with version and documentation (matches Windows app line 15)
            instructions += "                          Calculated Biblical Calendar        " + Version + CRLF + CRLF +
                   "       This software package has many uses, some of which will be briefly introduced" + CRLF +
                   "    here and covered in more detail in the individual Help files for each module." + CRLF + CRLF +
                   "        The default menu shows buttons to launch the HOLY DAYS and NEW MOON sections." + CRLF + CRLF +
                   "       HOLY DAYS estimates the dates of our God's Holy Days by calculating which evening" + CRLF +
                   "    the crescent of the New Moon would first be visible in Jerusalem. The calculations" + CRLF +
                   "    follow the Biblical principles governing Jehovah's Calendar, explained in our free" + CRLF +
                   "    article 'God's Calendar and the Sign of Jonah'. Another article, 'God's Holy Days" + CRLF +
                   "    for Christians', clarifies the meaning of Jehovah's Holy Days and shows that we are" + CRLF +
                   "    commanded to keep them. These articles are also available on our website. More" + CRLF +
                   "    detail on the calculations used in this module is given later in the" + CRLF;
            
            // Continue (matches Windows app line 16)
            instructions += "    documentation. These calculations are not a replacement for direct observation" + CRLF +
                   "    of the crescent new moon, but are instead an aid to assist in its observation." + CRLF +
                   "    The azimuth is measured in degrees clockwise from the South (90 is directly west)." + CRLF +
                   "    The setting times are for the evening of the given date, while the Holy Days" + CRLF +
                   "    begin on the evening before their given date. Though not stated in the output," + CRLF +
                   "    our Lord's Supper is observed on the previous evening which begins the Passover" + CRLF +
                   "    Sacrifice day." + CRLF + "    " + CRLF +
                   "        Enter the year you wish to calculate (leading minus sign for BCE (BC) years)" + CRLF +
                   "    and click on the Cup button.         (More information below)" + CRLF + CRLF +
                   "       NEW MOONS is accessed by clicking on the Crescent Moon button. It calculates the" + CRLF +
                   "    first evening the New Moon would be visible for twelve or thirteen months from " + CRLF +
                   "    March/April of the year selected until about April of the following year. It is " + CRLF +
                   "    useful for preparing a Biblical solar-lunar calendar. This section also uses" + CRLF +
                   "    Jerusalem as its reference point." + CRLF;
            
            // Continue (matches Windows app line 17)
            instructions += CRLF + "        The other sections, summarised below, can be accessed from the Menu Bar." + CRLF +
                   "    The data from any of the modules can be printed by selecting File, Print." + CRLF + CRLF +
                   "       CREATION calculates the day of the week for Abib 1 to determine which years" + CRLF +
                   "    are possibly the Creation Year. Genesis 2:2& 3, coupled with Exodus 20:11 confirm" + CRLF +
                   "    that the seventh day (Saturday in most of the world)is the Sabbath. This means" + CRLF +
                   "    that the Creation began on Sunday (ie, 'after sunset' on Saturday evening)." + CRLF +
                   "    The module creates a table of the years that could have begun on Sunday." + CRLF +
                   "    Bible chronology places the Creation year near 4004 BCE (BC)." + CRLF + CRLF +
                   "       FLOOD calculates the number of days between the 17th day of the second month" + CRLF +
                   "    and the 17th of the seventh month. We know from Genesis 7:11 and 8:3 that 'Noah's'" + CRLF +
                   "    Flood lasted 150 days, extending from the 17th day of the second month until the" + CRLF +
                   "    17th day of the seventh month.  This module runs a number of consecutive years" + CRLF +
                   "    and creates a table of the years that could have the required 150 days." + CRLF +
                   "    Bible chronology places the year of the Flood near 2348 BCE (BC)." + CRLF;
            
            // Continue (matches Windows app line 18)
            instructions += CRLF + "      JORDAN CROSSING calculates Passover (Abib 14) and the Wave Offering for the years" + CRLF +
                   "   that the Israelites would have crossed the Jordan to occupy Canaan." + CRLF +
                   "   This module helps pinpoint the year of the Crossing as it had to be a year in which" + CRLF +
                   "   the Passover occurred on a Sabbath (Joshua 5:11)." + CRLF + CRLF +
                   "      GOLGOTHA lists all the possible dates of Jesus Christ's (Jeshua the Messiah's)" + CRLF +
                   "   death and resurrection. As the Scriptures make plain, Jeshua was impaled at Golgotha" + CRLF +
                   "   on the afternoon of Abib 14, the Preparation Day of the Passover Feast. Jeshua" + CRLF +
                   "   said there was one sign that would prove he was the Christ: He would spend three days" + CRLF +
                   "   and three nights in the heart of the earth (Matthew chap.12, verses 39 & 40)." + CRLF +
                   "   This module shows that Jeshua fulfilled this sign precisely, confirming that He is the" + CRLF +
                   "   Anointed Christ." + CRLF + CRLF;
            
            // Continue (matches Windows app line 19)
            instructions += "       LOCAL MOONS calculates the New Moons for the coordinates in the 'Latitude' and" + CRLF +
                   "    'Longitude' boxes, allowing the user to verify the visibility of the new moon" + CRLF +
                   "    crescent in their own area. The 'GMT offset' box allows the user to select the" + CRLF +
                   "    local time zone for the location entered. The offset needs to be altered manually" + CRLF +
                   "    to adjust for daylight saving." + CRLF + CRLF +
                   "       SUNSETS calculates the sunset times for the coordinates in the 'Latitude' and" + CRLF +
                   "    'Longitude' boxes, providing the user with sunset times for the entire year." + CRLF + CRLF +
                   "       TIMES calculates the times of sunrise, sunset, moonrise, moonset and illuminated" + CRLF +
                   "    fraction of the moon for the coordinates in the 'Latitude' and 'Longitude' boxes," + CRLF +
                   "    providing the user with these times for the entire year." + CRLF + CRLF +
                   "       CONVERSIONS displays the date on four different calendars simultaneously. The" + CRLF +
                   "    date can be altered on any of the calendars and on clicking Compute, all of the" + CRLF +
                   "    calendars will be syncronised. Pressing F1 will bring up detailed help for this" + CRLF +
                   "    module (and the others too)." + CRLF + CRLF;
            
            // Continue (matches Windows app line 20)
            instructions += "       RABBINIC CALENDAR calculates the months and Holy Days using the standard Rabbinical" + CRLF +
                   "    calendar as defined by Hillel II in the fourth century AD and reiterated by Maimonides" + CRLF +
                   "    in the middle ages. It uses their various unbiblical postponements and decisions for" + CRLF +
                   "    the timing of their months and holy days." + CRLF + CRLF +
                   "       EASTER calculates the dates for the misnamed 'Good Friday' and 'Easter Sunday'." + CRLF +
                   "    Please note that these calculations are only provided for comparison purposes." + CRLF +
                   "    These are the counterfeits of the Babylonian system, NOT Jehovah God's Holy Days." + CRLF + CRLF +
                   "       CALCULATION PRINCIPLES" + CRLF +
                   "       These programs estimate the dates of God's Annual Holy Days by calculating the" + CRLF;
            
            // Continue (matches Windows app line 21)
            instructions += "    visibility of the New Moons in Jerusalem, using equations based on 'Astronomical" + CRLF +
                   "    Formula for Calculators' and 'Astronomical Algorithms', both by Jean Meeus." + CRLF +
                   "    (Published by Willmann-Bell Inc. USA)" + CRLF + CRLF +
                   "       The setting times given are for the evening(s) following the appropriate Sun-Moon " + CRLF +
                   "    conjunction. Each month begins the evening that the New Moon crescent is first " + CRLF +
                   "    visible. Each day begins at dusk on the previous date and ends at dusk on the date." + CRLF + CRLF +
                   "       This New Moon visibility calculation is used: Visibility number (VN) is the " + CRLF +
                   "    difference between the sun and moon setting times plus 27 times the illuminated" + CRLF +
                   "    percent of the moon plus 5.5 times the altitude of the moon at sunset minus" + CRLF +
                   "    5 times the altitude of the sun at moonset, all divided by 1.7. If the VN is " + CRLF +
                   "    < or = to 88 then the New Moon will not be seen; >88 to 100 will probably not be seen;" + CRLF;
            
            // Continue (matches Windows app line 22)
            instructions += "    >100 to 112 will probably be seen and anything greater than 112 will be seen" + CRLF +
                   "    in reasonable conditions." + CRLF + CRLF +
                   "         The beginning of the Biblical New Year is estimated by the probablility of barley" + CRLF +
                   "    growing near Jerusalem being ripe enough (Abib) to use in the Wave Offering ceremony" + CRLF +
                   "    that year. Our program presents alternatives for years where Jehovah God may alter the " + CRLF +
                   "    weather to select the day and/or month He wishes to use for His Holy Days that year." + CRLF +
                   "    The special date modules like 'Flood' use an older algorithm that calculates" + CRLF +
                   "    the vernal equinox to estimate the beginning of the year." + CRLF + CRLF +
                   "        Bible chronology, history and Biblical Calendar suggest these dates:" + CRLF +
                   "    The first day of Creation may have been 29/3/4004 BCE (BC). The Flood began during" + CRLF +
                   "    2348 BCE. Exodus was 1550 BCE and the crossing of the Jordan under Joshua was in" + CRLF +
                   "    1510 BCE. The dedication of Solomon's Tabernacle was 949 BCE. Messiah's birth was near" + CRLF +
                   "    the Day of Trumpets, 4 BCE. He was killed on April 23, 31 CE (AD) and resurrected" + CRLF +
                   "    after exactly three days and three nights in the tomb." + CRLF + CRLF +
                   "       Results are given in modified proleptic Gregorian Calendar dates, using a" + CRLF +
                   "    Day/Month/Year format. The modifications are adjustments for Hezekiah's 10 'steps'" + CRLF +
                   "    backwards (an extra 40 minutes on 5 Apr -651 BCE) and/or Joshua's long day (an extra" + CRLF +
                   "    day on 22 July, 1510 BCE), so data for times prior to these events will differ from" + CRLF +
                   "    standard proleptic Gregorian Calendars by these amounts." + CRLF + CRLF +
                   "       No Daylight Saving adjustments are made in any module." + CRLF + CRLF;
            
            // Continue (matches Windows app line 23 - the ending)
            instructions += "       All days begin at dusk in Israel and slowly move westward around the entire" + CRLF +
                   "    world, following the dusk. This means that all people living west of the " + CRLF +
                   "     International Date Line and east of Israel should begin their Holy Days after they have" + CRLF +
                   "    begun in Israel, as explained in two Dateline articles on our Web Site. These" + CRLF +
                   "    considerations also affect the weekly Sabbath in this region so their Sabbath" + CRLF +
                   "    also begins after it has begun in Israel." + CRLF + CRLF +
                   "       This one day delay should not be added if living (or examining events which" + CRLF +
                   "    occur) in Israel and/or the region westward to the International date line." + CRLF + CRLF +
                   "       If you need and/or want this program to make this correction to the Sabbath and" + CRLF +
                   "    Holy Days, you should check the box at the top of the screen." + CRLF + CRLF +
                   "                      Pressing F1 in any section will show its help screen." + CRLF + CRLF +
                   "    We thank the United States Naval Observatory for the moon images used in this program." + CRLF;
            
            return instructions;
        }

        private static string GetLocalMoonsDocumentation()
        {
            // Matches Windows app line 28
            return "                            LOCAL MOON - VISIBLE NEW MOON            " + Version + CRLF +
                   "        The LOCAL MOON section calculates the New Moons for the coordinates in the" + CRLF +
                   "    'Latitude' and 'Longitude' boxes, allowing the user to verify the visibility of the" + CRLF +
                   "    new moon crescent in their own area. The 'GMT offset' box allows the user to select" + CRLF +
                   "    the local time zone for the location entered. The offset needs to be altered manually" + CRLF +
                   "    to adjust for daylight saving." + CRLF + CRLF +
                   "         Some default locations are provided with the program, which can be selected by" + CRLF +
                   "    clicking on the down arrow to the right of the Location window. To enter a new" + CRLF +
                   "    location, enter its 'Longitude', 'Latitude' and Greenwich Mean Time offset in their" + CRLF +
                   "    boxes. Enter the new location name in the selection box. Then press the enter key" + CRLF +
                   "    and select 'Yes' to add the new location to your list of available locations." + CRLF + CRLF +
                   "        Enter the year you wish to calculate (use a negative sign for BCE (BC) years)" + CRLF +
                   "     and click on the Crescent Moon button." + CRLF + CRLF +
                   "        The coordinates and GMT for your new location can be found in various Atlas, maps" + CRLF +
                   "    or online by typing the location name into Google Earth's Fly to command. The " + CRLF +
                   "    coordinates will appear along the bottom of the screen." + CRLF + CRLF +
                   "      The various locations allow the accuracy of the New Moon calculations to be tested" + CRLF +
                   "    by direct observation and by comparing results against an ephemeris or newspaper" + CRLF +
                   "    setting times. The program will calculate the location's setting times and estimate" + CRLF +
                   "    visibility of the New Moon for each appropriate evening during the selected year." + CRLF + CRLF +
                   "      The azimuth is measured in degrees clockwise from the South (90 is directly west)." + CRLF +
                   "      Results are given in (proleptic) Gregorian Calendar dates, using Day/Month/Year format." + CRLF +
                   "      This Local Moons module does not adjust for Hezekiah's 10 'steps' backwards or Joshua's" + CRLF +
                   "    long day, so data for times prior to these events will not match with the Biblical Holy" + CRLF +
                   "    Days modules.  No Daylight Saving adjustments are made in any module." + CRLF + CRLF +
                   "      Use the Calendar convertor module to convert dates between various Calendars." + CRLF +
                   "      TIMES will give you moon and sun rising/setting for any day and location." + CRLF + CRLF +
                   "                Calculated Biblical Calendar       http://www.chcpublications.net" + CRLF;
        }

        private static string GetSunsetDocumentation()
        {
            return @"SUNSETS " + Version + @"

This section calculates the sunset times for the coordinates in the 'Latitude' and 'Longitude' boxes, providing the user with sunset times for the entire year for that location. The 'UTC/GMT offset' box allows the user to select the local time zone for the location entered. The setting times are not adjusted for daylight saving.

Enter the year (negative for BCE (BC) years) you wish to calculate and click on the Sunset button.";
        }

        private static string GetJordanDocumentation()
        {
            return @"THE JORDAN CROSSING " + Version + @"

This module calculates Passover (Abib 14) and the Wave Offering for the years that the Israelites would have crossed the Jordan to occupy Canaan.

The Israelites first ate the food of the Promised Land on the day after Passover (Joshua 5:11). They were not allowed to do this until the Feast of the First-Fruit [the Wave Offering] was kept (Leviticus 23:9-14). As the Biblical Wave Offering always occurs on the day after the Sabbath during the Feast of Unleavened Bread, it follows that the Passover (Preparation Day) had to be the Sabbath (Sat) that year.

Enter the initial year for the run in the left text box and the final year of the run in the text box beside the Flood button. Click the Crossing button to start the run.

Bible chronology gives a probable crossing date of 1510 BCE (BC).";
        }

        private static string GetFloodDocumentation()
        {
            return @"THE WORLD-WIDE FLOOD " + Version + @"

This module calculates the number of days between the 17th day of the second month and the 17th day of the seventh month. We know from Genesis 7:11 and 8:3 that 'Noah's' flood lasted 150 days, extending from the 17th day of the second month until the 17th day of the seventh month. This module runs through a number of consecutive years and creates a table of the years that could have the required 150 days.

Enter the initial year for the run in the left text box and the final year of the run in the text box beside the Flood button. Click the Flood button to start the run.

Bible chronology places the year of the Flood near 2348 BCE (BC).";
        }

        private static string GetCreationDocumentation()
        {
            return @"CREATION DATES (ABIB 1) " + Version + @"

This section calculates the day of the week for Abib 1 to determine which years are possibly the Creation Year. Genesis 2:2&3, coupled with Exodus 20:11 confirm that the seventh day (Saturday in most of the world) is the Sabbath. This means that the Creation began on Sunday (ie, after sunset on Saturday evening). The module creates a table of the years that could have begun on Sunday.

Calculations are for 42 Deg East Long. and 38.5 Deg North Lat., which may be the approximate location of the Garden of Eden.

Bible chronology gives a probable creation year of 4004 BCE. (BC)";
        }

        private static string GetGolgothaDocumentation()
        {
            return @"JESUS CHRIST'S (JESHUA MESSIAH'S) DEATH AND RESURRECTION (GOLGOTHA) " + Version + @"

This module shows all the possible dates of Jesus Christ's death and resurrection. As the Scriptures make plain, Jeshua (Jesus) was crucified at Golgotha on the afternoon of Abib 14, the Preparation Day of the Passover Feast.

Jesus said there was one sign that would prove He was the Christ: He would spend three days and three nights in the heart of the earth, and then rise from the dead. (Matthew chap.12, verses 39 & 40)

The program shows that in the year 31 C.E.(A.D.), the year that history, combined with the Bible, confirms as the year of His cruel death, the Passover was on Wednesday.

Enter the initial year for the run in the left text box and the final year of the run in the text box beside the Cross button. Click the Cross button to start the run.";
        }

        private static string GetTimesDocumentation()
        {
            return @"SUN AND MOON TIMES " + Version + @"

TIMES calculates the times of sunrise, sunset, moonrise, moonset and illuminated fraction for the coordinates in the 'Latitude' and 'Longitude' boxes, providing the user with these times for the entire year. The 'UTC/GMT offset' box allows the user enter the locality's time zone. The times are not adjusted for daylight saving.

Enter the year you wish to calculate (negative for BCE (BC) years) and click on the Sundial button.";
        }

        private static string GetRabbinicDocumentation()
        {
            return @"Rabbinical Calculated Calendar " + Version + @"

The Rabbinic module calculates the months and Holy Days using the standard Rabbinical calendar as defined by Hillel II in the fourth century AD and reiterated by Maimonides in the middle ages. It uses their various unbiblical postponements and decisions for the timing of their months and holy days.

Enter the Gregorian year you wish to calculate (negative for BCE (BC) years) and click on the Compute button.";
        }

        private static string GetEasterDocumentation()
        {
            return @"Easter Dates " + Version + @"

Easter calculates the dates for the misnamed 'Good Friday' and 'Easter Sunday', using the Roman Catholic method. Please note that these calculations are only provided for comparison purposes. These are fake holy days that are intended to deflect Christians from keeping Jehovah God's real Holy Days as taught in the Bible.

Enter the year (negative for BCE (BC) years) you wish to calculate and click on the Compute button. The dates for 60 years from the date you entered will be calculated.";
        }

        private static string GetConversionsDocumentation()
        {
            return @"Calendar Conversions " + Version + @"

CONVERSIONS displays the date on four different calendars simultaneously. The date can be altered on any of the calendars and on clicking Compute, all of the calendars will be syncronised. The Julian Day Number is also displayed.

The Rabbinical calendar uses the standard Jewish format, as noted in the separate documentation for their calendar.

Pressing F1 will bring up the help screen for this module (and the others too).";
        }

        private static string GetGeneralDocumentation()
        {
            return @"Calculated Biblical Calendar " + Version + @"

This software package calculates Biblical calendar dates and astronomical times based on the visibility of the new moon crescent in Jerusalem.

For more information about specific modules, please select a mode from the menu.";
        }
    }
}

