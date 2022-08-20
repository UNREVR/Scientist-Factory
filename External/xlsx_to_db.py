import sqlite3
import pandas as pd

xls_data = pd.read_excel("./변신마법.xlsx")
np_data = xls_data.to_numpy()
#xls_data.to_sql("변신마법", con=sqlite3.connect("변신마법.db"), if_exists="replace")
data = []
subject_dict = {
    "물리": 1,
    "수학": 2,
    "화학": 3,
    "생물": 4
}
era_dict = {
    "고대": 1,
    "중세": 2,
    "근대": 3,
    "현대": 4
}
sex_dict = {
    "남": 1,
    "여": 2
}
prize_dict = {
    "o": 1,
    "x": 2
}
region_dict = {
    "동": 1,
    "서": 2
}
marry_dict = {
    "미혼": 1,
    "1번": 2,
    "재혼": 3
}
subject = ""; era = ""; sex = ""; prize = ""; region = ""; marry = "";
for line in np_data:
    if line[0] in subject_dict:
        subject = subject_dict[line[0]]
    if line[1] in era_dict:
        era = era_dict[line[1]]
    if line[2] in sex_dict:
        sex = sex_dict[line[2]]
    if line[3] in prize_dict:
        prize = prize_dict[line[3]]
    if line[4] in region_dict:
        region = region_dict[line[4]]
    if line[5] in marry_dict:
        marry = marry_dict[line[5]]
    data.append([subject,
                 era,
                 sex,
                 prize,
                 region,
                 marry,
                 line[6],
                 line[7]
                 ])

with open("../Resources/data.bs", "w", encoding='UTF-8') as f:
    for i in data:
        f.write(f'{i[0]}|{i[1]}|{i[2]}|{i[3]}|{i[4]}|{i[5]}|{i[6]}|{i[7]}\n')

'''
db = sqlite3.connect("data.db")
curs = db.cursor()
curs.execute("CREATE TABLE IF NOT EXISTS data (subject INT, era INT, sex INT, prize INT, region INT, marry INT, name TEXT)")

for i in data:
    curs.execute("INSERT INTO data VALUES (?,?,?,?,?,?,?)", i)

db.commit()
db.close()
'''