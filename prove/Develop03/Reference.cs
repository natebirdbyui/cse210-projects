using System;
using System.Collections.Generic;

public class Reference
{
    
    private Dictionary<string, (int chapter, int startVerse, int endVerse, string text)> _scriptures; 
    
    public Reference()
    {
        _scriptures = new Dictionary<string, (int chapter, int startVerse, int endVerse, string text)>
        { //if single verses make sure to repeat same verse so the tuple will work (chapter, start verse, end verse) 
        // if single verse (chapter, verse, verse)
            {"John 3:16", (3, 16, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish," 
            + "but have everlasting life.") },
            {"1 Nephi 3:7", (3, 7, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, "
            + "for I know that the Lord giveth no commandments unto the children.") },
            {"D&C 4:2", (4, 2, 2, "Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, "
            + "that ye may stand blameless before God at the last day.") },
            {"Moroni 10:4-5", (10,4,5, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ,"
            + " if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you,"
            + "by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.") },
            {"1 Nephi 2:15", (2, 15, 24, "And my father dwelt in a tent."
            + "And it came to pass that I, Nephi, being exceedingly young, nevertheless being large in stature, "
            + "and also having great desires to know of the mysteries of God, wherefore, I did cry unto the Lord; and behold he did visit me, " 
            + "and did soften my heart that I did believe all the words which had been spoken by my father; wherefore, I did not rebel against him like unto my brothers."
            + "And I spake unto Sam, making known unto him the things which the Lord had manifested unto me by his Holy Spirit."
            + "And it came to pass that he believed in my words."
            + "But, behold, Laman and Lemuel would not hearken unto my words; and being grieved because of the hardness of their hearts "
            + "I cried unto the Lord for them."
            + "And it came to pass that the Lord spake unto me, saying: Blessed art thou, Nephi, because of thy faith, "
            + "for thou hast sought me diligently, with lowliness of heart."
            + "And inasmuch as ye shall keep my commandments, ye shall prosper, and shall be led to a land of promise;"
            +" yea, even a land which I have prepared for you; yea, a land which is choice above all other lands. "
            + "And inasmuch as thy brethren shall rebel against thee, they shall be cut off from the presence of the Lord."
            + "And inasmuch as thou shalt keep my commandments, thou shalt be made a ruler and a teacher over thy brethren."
            + "For behold, in that day that they shall rebel against me, I will curse them even with a sore curse, "
            + "and they shall have no power over thy seed except they shall rebel against me also. "
            + "And if it so be that they rebel against me, they shall be a scourge unto thy seed, to stir them up in the ways of remembrance.") },
            {"1 Nephi 1:1", (1, 1, 1, "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; "
            + "and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; "
            + "yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.") },
        };
    }
    public ScriptureData GetScripture(string reference)//this will get the scripture
    {
        if (_scriptures.TryGetValue(reference, out var scripture))//this will try to get the scripture from the dictionary
        {
            return new ScriptureData(reference, scripture.chapter, scripture.startVerse, scripture.endVerse, scripture.text);
        }
        throw new Exception("Scripture not found.");//this will throw an exception if the scripture is not found
    
    }
    public List<string> ScriptureReference()
    {
        return new List<string>(_scriptures.Keys);//this will return a list of the keys in the dictionary
    }
    public string GetRandomScriptureReference()
    {
        var keys = new List<string>(_scriptures.Keys);
        if (keys.Count == 0)
            return "No scriptures found.";

        Random random = new Random();
        return keys[random.Next(keys.Count)];
    }
}

