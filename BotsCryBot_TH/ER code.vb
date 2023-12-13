Table "Users" {
  "UserID" INT [pk]
  "username" VARCHAR(255)
  "num_likes" VARCHAR(255)
  "prayers_created" INT
}

Table "Creators" {
  "CreatorID" INT [pk]
  "CreatorName" VARCHAR(255)
  "AiCreator" VARCHAR(255)
}

Table "Prayers" {
  "PrayerID" INT [pk]
  "Prompt" VARCHAR(255)
  "PrayerBody" TEXT
  "NumLikes" INT
  "NumSaves" INT
  "Tag" varchar(255)
  "CoverImage" VARCHAR(255)
  "AudioRecitation" VARCHAR(255)
  "CreatorID" INT
}

Table "Scriptures" {
  "ScriptureID" INT [pk]
  "Scripture" VARCHAR(255)
  "PrayerID" INT
}

Table "Tags" {
  "TagID" INT [pk]
  "TagName" VARCHAR(255)
}

Table "Likes" {
  "LikeID" INT [pk]
  "UserID" INT
  "PrayerID" INT
  "Timestamp" TIMESTAMP
}

Table "Saves" {
  "SaveID" INT [pk]
  "UserID" INT
  "PrayerID" INT
  "Timestamp" TIMESTAMP
}

Ref:"Creators"."CreatorID" < "Prayers"."CreatorID"

Ref:"Prayers"."PrayerID" < "Scriptures"."PrayerID"

Ref:"Tags"."TagName" >   "Prayers"."Tag"

Ref:"Users"."UserID" < "Likes"."UserID"

Ref:"Prayers"."PrayerID" < "Likes"."PrayerID"

Ref:"Users"."UserID" < "Saves"."UserID"

Ref:"Prayers"."PrayerID" < "Saves"."PrayerID"
