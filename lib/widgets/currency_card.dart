import 'package:flutter/material.dart';

class CurrencyCard extends StatelessWidget {
  final String name, code, amount;
  final IconData icon;
  final bool isInverted;
  final _blackColor = const Color(0xff1f2123);
  final bool isFirst;

  const CurrencyCard({
    super.key,
    required this.name,
    required this.code,
    required this.amount,
    required this.icon,
    required this.isInverted,
    required this.isFirst,
  });

  @override
  Widget build(BuildContext context) {
    return Transform.translate(
      offset: isFirst ? const Offset(0, 0) : const Offset(0, -40),
      child: Container(
        clipBehavior: Clip.hardEdge, // 삐져나온 아이콘을 컨테이너 크기로 잘라냄
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(30),
          color: isInverted ? _blackColor : Colors.white,
        ),
        child: Padding(
          padding: const EdgeInsets.all(30),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    name,
                    style: TextStyle(
                      color: isInverted ? Colors.white : _blackColor,
                      fontSize: 30,
                      fontWeight: FontWeight.w600,
                    ),
                  ),
                  const SizedBox(
                    height: 10,
                  ),
                  Row(
                    children: [
                      Text(
                        amount,
                        style: TextStyle(
                          color: isInverted ? Colors.white : _blackColor,
                          fontSize: 18,
                        ),
                      ),
                      const SizedBox(
                        width: 5,
                      ),
                      Text(
                        code,
                        style: TextStyle(
                          color: isInverted
                              ? Colors.white.withOpacity(0.8)
                              : _blackColor,
                          fontSize: 18,
                        ),
                      ),
                    ],
                  ),
                ],
              ),
              Transform.scale(
                // 아이콘을 확대시킨 위젯클래스
                scale: 2.2,
                child: Transform.translate(
                  // 아이콘의 위치를 x,y축을 기준으로 이동시키는 위젯클래스
                  offset: const Offset(
                      -5, 12), // Transform.translate()클래스의 필수 네임드 파라미터
                  child: Icon(
                    icon,
                    color: isInverted ? Colors.white : _blackColor,
                    size: 85,
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}
