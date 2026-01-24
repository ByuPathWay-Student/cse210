using System.Diagnostics.Contracts;

public class ScriptureDatabase
{
    List<Scripture> _scriptures;

    public ScriptureDatabase()
    {
        _scriptures = new List<Scripture>();
        Reference reference = new Reference("1 Nephi", 2, 15);
        string scriptureVerse = "And my father dwelt in a tent.";
        Scripture scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("1 Nephi", 3, 7);
        scriptureVerse = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("Helaman", 3, 29, 30);
        scriptureVerse = "Yea, we see that whosoever will may lay hold upon the word of God, which is quick and powerful, which shall divide asunder all the cunning and the snares and the wiles of the devil, and lead the man of Christ in a strait and narrow course across that everlasting gulf of misery which is prepared to engulf the wicked— And land their souls, yea, their immortal souls, at the right hand of God in the kingdom of heaven, to sit down with Abraham, and Isaac, and with Jacob, and with all our holy fathers, to go no more out.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("Moses", 5, 6);
        scriptureVerse = "And after many days an angel of the Lord appeared unto Adam, saying: Why dost thou offer sacrifices unto the Lord? And Adam said unto him: I know not, save the Lord commanded me.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("Mark", 2, 27, 28);
        scriptureVerse = "And he said unto them, The sabbath was made for man, and not man for the sabbath: Therefore the Son of man is Lord also of the sabbath.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("1 Corinthians", 11, 11);
        scriptureVerse = "Nevertheless neither is the man without the woman, neither the woman without the man, in the Lord.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("Job", 32, 8);
        scriptureVerse = "But there is a spirit in man: and the inspiration of the Almighty giveth them understanding.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("Malachi", 4, 5, 6);
        scriptureVerse = "Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the Lord: And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("2 Nephi", 9, 41);
        scriptureVerse = "O then, my beloved brethren, come unto the Lord, the Holy One. Remember that his paths are righteous. Behold, the way for man is narrow, but it lieth in a straight course before him, and the keeper of the gate is the Holy One of Israel; and he employeth no servant there; and there is none other way save it be by the gate; for he cannot be deceived, for the Lord God is his name.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);

        reference = new Reference("Mosiah", 2, 17);
        scriptureVerse = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        scripture = new Scripture(reference, scriptureVerse);
        _scriptures.Add(scripture);
    }
    public Scripture GetRandomScripture()
    {
        Random randomScripture = new Random();
        int index = randomScripture.Next(0,_scriptures.Count);
        Scripture scripture = _scriptures[index];
        return scripture;
    }
}