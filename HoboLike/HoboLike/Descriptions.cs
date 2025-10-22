using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboLike
{
    internal class Descriptions
    {
        private static Random rng = new Random();

        private static string[] AlleyDescriptions = 
        {
            "A narrow alley reeks of wet cardboard and old grease, the stink clinging to the brick like a film.\nThe streetlight at the mouth flickers once, twice, and then holds, casting a sickly halo that doesn’t reach the back wall.\nBeyond it, the dark sits heavy, pooling in doorways and under the fire escape.\n",
            "Wind snakes between the buildings and rattles a loose grate until it chatters like teeth.\nA cat perches on a dented dumpster lid, yellow eyes steady, tail twitching with small, decisive cuts.\nSomewhere high above, a bottle rolls and knocks, then goes quiet.\n",
            "Rain needles down and turns every puddle into a warped mirror of broken neon.\nGraffiti bleeds under the water, colors running until they look bruised.\nFrom deeper in the alley comes the dry crunch of glass, followed by the faint scrape of metal against stone.\n",
            "Morning sun slides in at an angle, lifting the gray into something softer.\nDust motes drift lazily and gather in the warm beam like slow snow.\nBetween two bricks, a shallow recess rests dry and undisturbed, a small pocket of quiet.\n",
            "A line of laundry stretches overhead—socks, two shirts, a faded scarf that catches the breeze.\nThe cloth flutters against the sky and turns the space briefly domestic.\nThe smell of soap lingers just enough to cut through the city’s damp.\n",
            "After the storm, the air smells rinsed and new.\nPuddles settle into glassy ovals that hold a sliver of bright blue between the roofs.\nThe alley breathes, brick by brick, as if relieved to have weathered another night.\n"
        };
        public static string GetAlleyDescription()
        {
            return AlleyDescriptions[(rng.Next(AlleyDescriptions.Length))];
        }

        private static string[] UnderpassDescriptions =
        {
            "Concrete thrums with the weight of traffic above, a steady bass note that never stops.\nDamp climbs the pillars in tide lines, and diesel hangs low, heavy as a curtain.\nThe fluorescent tubes stutter, stitching the space into uneven bands of light and shadow.\n",
            "Water beads along the ceiling and taps into scattered puddles in a patient rhythm.\nA shopping cart lies on its side, one wheel still quivering from some long-past nudge.\nPigeons shuffle in the rafters, all rustle and wing, never quite revealing themselves.\n",
            "The mural across the far wall is washed to ghosts, outlines where color used to be.\nCold funnels down the length of the span and sets small things shivering—paper scraps, a plastic ribbon, the edge of a poster.\nThe sound of a siren arrives thin and late, swallowed by concrete.\n",
            "Daylight gathers at both ends and meets in the middle, turning the space into a long, dry corridor.\nTire noise becomes a muted lullaby when it blends with the rivering wind.\nChalk pastels brighten a pillar in soft bands that refuse to fade.\n",
            "Someone has swept a corner clean: bare concrete, neatly stacked crates, a patch where the dust doesn’t settle.\nThe hum above softens to a steady comfort, a sign that the world keeps moving.\nThe air is out of the rain and almost warm.\n",
            "The storm roars on the roadway, but underneath it thins to a hush.\nDrips slow, then stop, and a pale light filters through like gauze.\nThe underpass feels briefly like a sanctuary carved out of noise.\n"
        };
        public static string GetUnderpassDescription()
        {
            return UnderpassDescriptions[(rng.Next(UnderpassDescriptions.Length))];
        }

        private static string[] AbandonedHouseDescriptions =
        {
            "The front door sags on a single hinge and complains when the wind shifts.\nInside, wallpaper curls off the plaster in long, brittle tongues, revealing the bone-white beneath.\nDust hangs in the stale rooms until a draft stirs it into a dull glitter.\n",
            "Every floorboard answers with a tired groan, as if the house has learned to speak only in aches.\nA staircase climbs into a darkness that never quite gives anything back.\nIn the living room, a single shoe rests beside a toppled chair, and the absence hums.\n",
            "The kitchen smells of rust and rainwater, tin and old wood.\nA calendar on the wall stopped years ago, its pages faded to a quiet sepia.\nThe sink holds a film that catches the light in a thin, sickle-shaped sheen.\n",
            "Despite the leaks along the eaves, the central room stands dry and still.\nSunlight slips through a cracked pane and lays a clean stripe on the floorboards, warming the dust to a soft gold.\nThe curtain stirs in the mild draft like something that remembers how to breathe.\n",
            "The hearth is soot-stained but sound, bricks set with a kind of stubborn dignity.\nIn the quiet, the house feels less empty than paused, waiting for the next chapter to be written across its walls.\nA faint scent of pine drifts in from the overgrown yard.\n",
            "Vines curl around the porch rail in patient spirals, bright green against the gray.\nBirds chatter in the eaves and stitch the silence back together.\nIn the back room, the light lingers longer than it needs to, and the space holds onto the warmth.\n"
        };
        public static string GetAbandonedHouseDescription()
        {
            return AbandonedHouseDescriptions[(rng.Next(AbandonedHouseDescriptions.Length))];
        }

        private static string IntroText =
            "No keys. No bed. Only streets that never sleep.\n" +
            "You have 3 days to make it before your buddy gets back from vacation, and a worn-out sofa becomes your haven.\n" +
            "Until then, trash cans, underpasses, and abandoned houses are your best friends—but beware, dangers lurk around every corner.\n" +
            "Three days. No guarantees. Stay alive. \n" +
            "The Alley is where your journey will start, choose your next step wisely.\n\n" +
            "(Press any key to step into the night)\n";
        public static string GetIntroText()
        {
            return IntroText;
        }


    }
}
