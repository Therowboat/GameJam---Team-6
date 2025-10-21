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
            "A narrow alley reeks of wet cardboard and old grease, the stink clinging to the brick like a film. The streetlight at the mouth flickers once, twice, and then holds, casting a sickly halo that doesn’t reach the back wall. Beyond it, the dark sits heavy, pooling in doorways and under the fire escape.",
            "Wind snakes between the buildings and rattles a loose grate until it chatters like teeth. A cat perches on a dented dumpster lid, yellow eyes steady, tail twitching with small, decisive cuts. Somewhere high above, a bottle rolls and knocks, then goes quiet.",
            "Rain needles down and turns every puddle into a warped mirror of broken neon. Graffiti bleeds under the water, colors running until they look bruised. From deeper in the alley comes the dry crunch of glass, followed by the faint scrape of metal against stone.",
            "Morning sun slides in at an angle, lifting the gray into something softer. Dust motes drift lazily and gather in the warm beam like slow snow. Between two bricks, a shallow recess rests dry and undisturbed, a small pocket of quiet.",
            "A line of laundry stretches overhead—socks, two shirts, a faded scarf that catches the breeze. The cloth flutters against the sky and turns the space briefly domestic. The smell of soap lingers just enough to cut through the city’s damp.",
            "After the storm, the air smells rinsed and new. Puddles settle into glassy ovals that hold a sliver of bright blue between the roofs. The alley breathes, brick by brick, as if relieved to have weathered another night."
        };
        public static string GetAlleyDescription()
        {
            return AlleyDescriptions[(rng.Next(AlleyDescriptions.Length))];
        }

        private static string[] UnderpassDescriptions =
        {
            "Concrete thrums with the weight of traffic above, a steady bass note that never stops. Damp climbs the pillars in tide lines, and diesel hangs low, heavy as a curtain. The fluorescent tubes stutter, stitching the space into uneven bands of light and shadow.",
            "Water beads along the ceiling and taps into scattered puddles in a patient rhythm. A shopping cart lies on its side, one wheel still quivering from some long-past nudge. Pigeons shuffle in the rafters, all rustle and wing, never quite revealing themselves.",
            "The mural across the far wall is washed to ghosts, outlines where color used to be. Cold funnels down the length of the span and sets small things shivering—paper scraps, a plastic ribbon, the edge of a poster. The sound of a siren arrives thin and late, swallowed by concrete.",
            "Daylight gathers at both ends and meets in the middle, turning the space into a long, dry corridor. Tire noise becomes a muted lullaby when it blends with the rivering wind. Chalk pastels brighten a pillar in soft bands that refuse to fade.",
            "Someone has swept a corner clean: bare concrete, neatly stacked crates, a patch where the dust doesn’t settle. The hum above softens to a steady comfort, a sign that the world keeps moving. The air is out of the rain and almost warm.",
            "The storm roars on the roadway, but underneath it thins to a hush. Drips slow, then stop, and a pale light filters through like gauze. The underpass feels briefly like a sanctuary carved out of noise."
        };
        public static string GetUnderpassDescription()
        {
            return UnderpassDescriptions[(rng.Next(UnderpassDescriptions.Length))];
        }

        private static string[] AbandonedHouseDescriptions =
        {
            "The front door sags on a single hinge and complains when the wind shifts. Inside, wallpaper curls off the plaster in long, brittle tongues, revealing the bone-white beneath. Dust hangs in the stale rooms until a draft stirs it into a dull glitter.",
            "Every floorboard answers with a tired groan, as if the house has learned to speak only in aches. A staircase climbs into a darkness that never quite gives anything back. In the living room, a single shoe rests beside a toppled chair, and the absence hums.",
            "The kitchen smells of rust and rainwater, tin and old wood. A calendar on the wall stopped years ago, its pages faded to a quiet sepia. The sink holds a film that catches the light in a thin, sickle-shaped sheen.",
            "Despite the leaks along the eaves, the central room stands dry and still. Sunlight slips through a cracked pane and lays a clean stripe on the floorboards, warming the dust to a soft gold. The curtain stirs in the mild draft like something that remembers how to breathe.",
            "The hearth is soot-stained but sound, bricks set with a kind of stubborn dignity. In the quiet, the house feels less empty than paused, waiting for the next chapter to be written across its walls. A faint scent of pine drifts in from the overgrown yard.",
            "Vines curl around the porch rail in patient spirals, bright green against the gray. Birds chatter in the eaves and stitch the silence back together. In the back room, the light lingers longer than it needs to, and the space holds onto the warmth."
        };
        public static string GetAbandonedHouseDescription()
        {
            return AbandonedHouseDescriptions[(rng.Next(AbandonedHouseDescriptions.Length))];
        }

    }
}
