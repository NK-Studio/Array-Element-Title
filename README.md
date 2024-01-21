# Array Element Title
## 소개

![Image.png](Image%2FImage.png)  
배열 또는 리스트를 사용할 때 Element의 이름을 지정할 수 있습니다.

## 설치

### Git UPM
Array Element Title 패키지를 설치하려면 다음 단계가 필요합니다.
1. Git이 설치되어 있는지 확인하십시오.
2. Package Manager를 오픈합니다.
3. +버튼을 클릭하고, Add package from git URL을 클릭합니다.
4. `https://github.com/NK-Studio/Array-Element-Title.git#UPM` 를 입력하고 추가 버튼을 클릭하세요.
   
### Unity Package
[Releases](https://github.com/NK-Studio/Array-Element-Title/releases)에서 최신 버전의 패키지를 다운로드 받아 설치합니다.
## 사용법

```cs
[System.Serializable]
public class Person
{
    public string Name;
    public int Age;
}

public class TestCode : MonoBehaviour
{
    [ArrayElementTitle("Name")]
    public Person[] Persons;
}
```
타이틀의 제목으로 사용할 변수를 `ArrayElementTitle` 의 괄호에 작성합니다.

## 지원되는 자료형
 - ✅ : 지원
 - ❌ : 미지원

| SerializedPropertyType | 지원 여부 |
| ---------------------- |-------|
| Integer                | ✅    |
| Boolean                | ✅    |
| Float                  | ✅    |
| String                 | ✅    |
| Color                  | ✅    |
| ObjectReference        | ✅    |
| Enum                   | ✅    |
| Vector2                | ✅    |
| Vector3                | ✅    |
| Vector4                | ✅    |
| Generic                | ❌     |
| LayerMask              | ❌     |
| Rect                   | ❌     |
| ArraySize              | ❌     |
| Character              | ❌     |
| AnimationCurve         | ❌     |
| Bounds                 | ❌     |
| Gradient               | ❌     |
| Quaternion             | ❌     |
| ExposedReference       | ❌     |
| FixedBufferSize        | ❌     |
| Vector2Int             | ❌     |
| Vector3Int             | ❌     |
| RectInt                | ❌     |
| BoundsInt              | ❌     |
